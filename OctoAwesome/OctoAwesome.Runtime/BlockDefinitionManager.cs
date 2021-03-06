﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OctoAwesome.Runtime
{
    public static class BlockDefinitionManager
    {
        private static List<IBlockDefinition> definitions;

        public static IEnumerable<IBlockDefinition> GetBlockDefinitions()
        {
            if (definitions == null)
            {
                definitions = new List<IBlockDefinition>();
                definitions.AddRange(ExtensionManager.GetInstances<IBlockDefinition>());
            }

            return definitions;
        }
    }
}
