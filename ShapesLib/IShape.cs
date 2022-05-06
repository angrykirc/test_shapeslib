using System;

namespace ShapesLib
{
    public interface IShape
    {
        /// <summary>
        /// Gets the area of the shape.
        /// </summary>
        /// <returns>The area.</returns>
        double GetArea();
        /// <summary>
        /// Checks if given shape is valid/correct.
        /// </summary>
        /// <returns>true if correct, false if otherwise.</returns>
        bool IsValid();

        /// <summary>
        /// Returns human readable string describing the shape.
        /// </summary>
        /// <returns>The info.</returns>
        string DebugInfo();
    }
}