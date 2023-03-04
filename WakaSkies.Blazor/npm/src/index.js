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
    const amb = new THREE.AmbientLight(0xa6a6a6);
    const point = new THREE.PointLight();
    point.position.z = 10;
    point.castShadow = true;
    scene.add(amb);
    scene.add(point);

    const helper = new THREE.PointLightHelper(point);
    scene.add(helper);

    // setup the renderer
    renderer = new THREE.WebGLRenderer({ canvas: document.getElementById('threeCanvas'), antialias: true });
    renderer.setSize(window.innerWidth, window.innerHeight);

    // add the debug controls.
    controls = new OrbitControls(camera, renderer.domElement);

    // add the debug axis.
    const axesHelper = new THREE.AxesHelper( 5 );
    scene.add( axesHelper );

    controls.update();
    animate();
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

    // https://stackoverflow.com/a/26471195
    const material = new THREE.MeshPhongMaterial({ side: THREE.DoubleSide });
    modelMesh = new THREE.Mesh(geometry, material);
    modelMesh.receiveShadow = true;
    modelMesh.position.x = -30;
    scene.add(modelMesh);
}

/**
 * Animate.
 */
function animate() {
    requestAnimationFrame(animate);
    renderer.render(scene, camera);
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