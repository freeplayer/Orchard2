﻿using System;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Mvc.Utilities;

namespace OrchardCore.ContentManagement.Metadata.Models
{
    public static class ContentPartExtensions
    {
        public static string DisplayName(this ContentPartDefinition part)
        {
            var displayName = part.Settings.ToObject<ContentPartSettings>().DisplayName;

            if (String.IsNullOrEmpty(displayName))
            {
                displayName = part.Name.TrimEnd("Part");
            }

            return displayName;
        }

        public static string Description(this ContentPartDefinition part)
        {
            var description = part.Settings.ToObject<ContentPartSettings>().Description;

            return description;
        }
    }
}
