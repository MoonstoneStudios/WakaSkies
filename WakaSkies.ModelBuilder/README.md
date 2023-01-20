# WakaSkies.WakaModelBuilder
The model builder project handles building a model for the front-end to render.

The model will be generated using rectangles made of quads at first. Then it will be triangulated for rendering and STL support. 
Quads are created and manipulated first; it makes it easier to change the shape of the rectangles.
Each rectangle's height will represent the amount of hours on a specific date.

Once the rectangles are in the right places the all the models will be triangulated. 
Triangulation is the process of taking a polygon and dividing the shape into triangles. 
These triangles will be sent to the renderer and when a download is requested, will be turned into STL format.

There is a base model that will be appended to the rectangles. The rectangles will rest on the base.