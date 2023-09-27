using UnityEngine;

namespace Arcweave
{
    ///<summary>An interface for all things a connection can have as source and/or target</summary>
    public interface INode
    {
        string id { get; }
        Vector2Int pos { get; }
        Project project { get; }
        void InitializeInProject(Project project);
        Path ResolvePath(Path path);
    }
}