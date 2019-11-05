﻿using MtbMate.Models;

namespace MtbMate.Contexts {
    public class MainContext {
        public StorageContext Storage { get; }
        public UIContext UI { get; }
        public SecurityContext Security { get; }
        public Settings Settings { get; }

        public MainContext() {
            Storage = new StorageContext();
            UI = new UIContext(this);
            Security = new SecurityContext();
            Settings = Storage.GetSettings();
        }
    }
}
