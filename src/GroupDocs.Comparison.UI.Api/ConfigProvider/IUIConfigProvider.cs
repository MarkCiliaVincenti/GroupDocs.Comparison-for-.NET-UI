﻿using GroupDocs.Comparison.UI.Core.Configuration;

namespace GroupDocs.Comparison.UI.Api
{
    public interface IUIConfigProvider
    {
        void ConfigureUI(Core.Configuration.Config config);
    }
}
