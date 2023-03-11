// https://brianlagunas.com/using-npm-packages-in-blazor/
import * as THREE from 'three';
import { OrbitControls } from 'three/addons/controls/OrbitControls.js';

// the scene.
var scene;
// the camera.
var camera;
// the renderer.
var renderer;
// the orbit controls.
var controls;

// the mesh of the waka model.
var modelMesh;
// Half of the width to move the model by so it is centered.
var halfWidth;

// if the camera is paused.
var cameraPaused = true;

/**
 * Create the scene.
 */
window.createScene = function() {
    camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
    // https://stackoverflow.com/a/44781658
    camera.up.set(0,0,1);
    camera.position.y = -30;

    // create the scene.
    scene = new THREE.Scene();

    // create the lights
    const amb = new THREE.AmbientLight(0xf2f2f2);
    const point = new THREE.DirectionalLight();
    point.position.set(5,-11,7);
    point.castShadow = true;
    scene.add(amb);
    scene.add(point);

    // setup the renderer
    renderer = new THREE.WebGLRenderer({ canvas: document.getElementById('threeCanvas'), antialias: true });
    renderer.setSize(window.innerWidth, window.innerHeight);

    // add the camera controls.
    controls = new OrbitControls(camera, renderer.domElement);
    controls.autoRotateSpeed = 0.4;
    controls.enableDamping = true;
    controls.minPolarAngle = 1;
    controls.maxPolarAngle = 1;
    controls.enableZoom = false;
    controls.minDistance = 45;
    controls.enablePan = false;
    controls.enableRotate = false;
    
    controls.addEventListener("end", userManuallyRotated);
    
    // create the skybox
    createSkybox(getRandomInt(7));
    
    controls.update();
    
    // start the scene render loop.
    animate();
}

/**
 * Generate the skybox.
 * @param {number} index The index of the skybox to set as the BG.
 */
// https://threejs.org/docs/index.html?q=cube#api/en/loaders/CubeTextureLoader
function createSkybox(index){
    scene.background = new THREE.CubeTextureLoader()
	.setPath( `img/Skyboxes/${index}/` )
	.load( [
        'right.png',
		'left.png',
		'top.png',
		'bottom.png',
		'front.png',
		'back.png'
	] );
}


/**
 * Get random int.
 * @param {*} max The exclusive max.
 * @returns {number} A random int.
 * @copyright https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Math/random
 */
function getRandomInt(max) {
    return Math.floor(Math.random() * max);
}

/**
 * Create the THREE.js version of the WakaModel.
 * @param {*} verts The vertices.
 * @param {*} normals The normals.
 * @param {*} unmarshalled If the function call is unmarshalled.
 */
window.createModel = function (verts, normals, unmarshalled) {
    var vertsArray;
    var normalsArray;
    
    if (unmarshalled) {
        var vertsArray = toFloatArray(verts);
        var normalsArray = toFloatArray(normals);
    } else {
        vertsArray = Float32Array.from(verts);
        normalsArray = Float32Array.from(normals);
    }
    
    // if model is already generated, remove it.
    if (scene.children.includes(modelMesh)) {
        scene.remove(modelMesh);
    }
    
    const geometry = new THREE.BufferGeometry();
    geometry.setAttribute('position', new THREE.BufferAttribute(vertsArray, 3));
    geometry.setAttribute('normal', new THREE.BufferAttribute(normalsArray, 3));
    geometry.computeVertexNormals();
    
    // https://stackoverflow.com/a/26471195
    const material = new THREE.MeshPhongMaterial({ side: THREE.DoubleSide, color: 0xa3a3a3, specular: 0xfefefe, shininess: 0, reflectivity: 0, vertexColors: true});
    modelMesh = new THREE.Mesh(geometry, material);
    modelMesh.castShadow = true;
    modelMesh.receiveShadow = true;

    // add 4 for a little shift to the side to make it look better.
    modelMesh.position.x = -halfWidth + 4;
    modelMesh.position.y = 4;
    scene.add(modelMesh);

    controls.autoRotate = true;
    controls.enableRotate = true;
    cameraPaused = false;
}

/**
 * Half of the width to move the model by so it is centered.
 */ 
window.setHalfWidth = function(half){
    halfWidth = half;
}

/**
 * Animate.
 */
function animate() {
    requestAnimationFrame(animate);

    //https://threejs.org/manual/#en/responsive
    if (resizeRendererToDisplaySize(renderer)) {
        const canvas = renderer.domElement;
        camera.aspect = canvas.clientWidth / canvas.clientHeight;
        camera.updateProjectionMatrix();
    }

    // update auto rotate.
    controls.update();
    // render the scene.
    renderer.render(scene, camera);
}

/**
 * @copyright https://threejs.org/manual/#en/responsive
 */
function resizeRendererToDisplaySize(renderer) {
    const canvas = renderer.domElement;
    const pixelRatio = window.devicePixelRatio;
    const width  = canvas.clientWidth  * pixelRatio | 0;
    const height = canvas.clientHeight * pixelRatio | 0;
    const needResize = canvas.width !== width || canvas.height !== height;
    if (needResize) {
      renderer.setSize(width, height, false);
    }
    return needResize;
  }

/**
 * Print to the console.
 * @param {*} obj what to print.
 */
window.writeLine = function(obj) {
    console.log(obj);
}

/**
 * Convert the unmarshalled list of floats to a JS array.
 * The marshalled call to createModel takes a while. If unmarshalled calling is supported,
 * it uses it. This speeds up the JS interopt call drastically.
 * @param {*} floats The float array to convert into a JS array.
 * @returns A Float32Array.
 * @copyright https://stackoverflow.com/a/64626309
 */
function toFloatArray(floats) {
    var m = floats + 12;
    var r = Module.HEAP32[m >> 2];
    var j = new Float32Array(Module.HEAPF32.buffer, m + 4, r);
    return j;
}

/**
 * When the user has manually rotated, pause auto rotation for 2 seconds.
 * Credit on async func and await statement: https://stackoverflow.com/a/47480429
 */
async function userManuallyRotated(){
    controls.autoRotate = false;

    await delay(2000);

    // if camera is already paused don't unpuase it.
    if (!cameraPaused){
        controls.autoRotate = true;
    }
}

/**
 * Delay for miliseconds
 * @param {*} ms Miliseconds to delay
 * @copyright https://stackoverflow.com/questions/14226803/wait-5-seconds-before-executing-next-line#comment114272794_47480429
 */
const delay = async (ms) => new Promise(res => setTimeout(res, ms));

window.pauseCamera = function(){
    controls.autoRotate = false;
    controls.enableRotate = false;
    cameraPaused = true;
}

window.unpauseCamera = function() {
    controls.autoRotate = true;
    controls.enableRotate = true;
    cameraPaused = false;
}
