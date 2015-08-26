﻿// Copyright 2015 afuzzyllama. All Rights Reserved.

using System;
using UnityEngine;

namespace ProceduralVoxelMesh
{
    /// <summary>
    /// Represents a single voxel.
    /// </summary>
    public struct Voxel
    {
        /// <summary>
        /// Is the voxel empty or not
        /// </summary>
        public bool Empty;

        private Color _color;
        /// <summary>
        /// Color of the voxel
        /// </summary>
        public Color Color
        {
            get
            {
                if (Empty == true)
                {
                    throw new InvalidOperationException("Cannot get the color of an empty voxel");
                }
                return _color;
            }
            set
            {
                Empty = false;
                _color = value;
            }
        }

        public Voxel(bool empty, Color? color = null)
        {
            Empty = empty;

            if (!empty)
            {
                if (color == null)
                {
                    throw new System.ArgumentException("If not empty, color cannot be null");
                }
                _color = (Color) color;
            }
            else
            {
                _color = Color.black;
            }
        }
    }
}
