namespace AirEase_AMS.Application.Defs.Struct;

public interface INode
{
    bool Adjacent(INode x, INode y);
    INode[] Neighbors(INode x);

    void AddVertex(INode x);

    void RemoveVertex(INode x);

    void AddEdge(INode x, INode y);

    void RemoveEdge(INode x, INode y);

    int GetVertexVal(INode x);

    void SetVertexVal(INode x);
}