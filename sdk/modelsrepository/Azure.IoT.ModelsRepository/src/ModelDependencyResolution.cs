﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.IoT.ModelsRepository
{
    /// <summary>
    /// The model dependency resolution options.
    /// </summary>
    public enum ModelDependencyResolution
    {
        /// <summary>
        /// Disable model dependency resolution.
        /// </summary>
        Disabled,

        /// <summary>
        /// Enable model dependency resolution. The client will parse
        /// models and calculate dependencies recursively.
        /// </summary>
        Enabled,

        /// <summary>
        /// Try to get pre-computed model dependencies using .expanded.json.
        /// If the model expanded form does not exist fall back to ModelDependencyResolution.Enabled processing.
        /// </summary>
        TryFromExpanded
    }
}
