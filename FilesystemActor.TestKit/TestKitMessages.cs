﻿namespace FilesystemActor.TestKit
{
    public class SetupComplete { }

    public class EnterSetup { }

    public class CreateTestFolder
    {
        public CreateTestFolder(string Path) => this.Path = Path;

        public string Path { get; }
    }

    public class CreateTestFile
    {
        public CreateTestFile(string Path) => this.Path = Path;

        public string Path { get; }
    }
    
    public class LockTestFile
    {
        public LockTestFile(string Path) => this.Path = Path;

        public string Path { get; }
    }

    public class UnlockTestFile
    {
        public UnlockTestFile(string Path) => this.Path = Path;

        public string Path { get; }
    }
}
