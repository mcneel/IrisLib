﻿using Newtonsoft.Json;

namespace THREE
{
    /// <summary>
    /// Camera that uses orthographic projection.
    /// In this projection mode, an object's size in the rendered image stays constant regardless of its distance from the camera.
    /// This can be useful for rendering 2D scenes and UI elements, amongst other things.
    /// Analogous to: https://threejs.org/docs/index.html#api/cameras/OrthographicCamera
    /// JS Source: https://github.com/mrdoob/three.js/blob/master/src/cameras/OrthographicCamera.js
    /// </summary>
    public class OrthographicCamera : Camera
    {

        /// <summary>
        /// Camera frustum bottom plane.
        /// </summary>
        [JsonProperty("bottom")]
        public float Bottom { get; set; }

        /// <summary>
        /// Camera frustum far plane. 
        /// The valid range is between the current value of the near plane and infinity.
        /// </summary>
        [JsonProperty("far")]
        public float Far { get; set; }

        /// <summary>
        /// Camera frustum left plane.
        /// </summary>
        [JsonProperty("left")]
        public float Left { get; set; }

        /// <summary>
        /// Camera frustum near plane.
        /// The valid range is between 0 and the current value of the far plane.Note that, unlike for the PerspectiveCamera, 0 is a valid value for an OrthographicCamera's near plane. 
        /// </summary>
        [JsonProperty("near")]
        public float Near { get; set; }

        /// <summary>
        /// Camera frustum right plane.
        /// </summary>
        [JsonProperty("right")]
        public float Right { get; set; }

        /// <summary>
        /// Camera frustum top plane.
        /// </summary>
        [JsonProperty("top")]
        public float Top { get; set; }

        /// <summary>
        /// Gets or sets the zoom factor of the camera.
        /// </summary>
        [JsonProperty("zoom")]
        public float Zoom { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public OrthographicCamera()
        {
            Type = GetType().Name;
        }
    }
}
