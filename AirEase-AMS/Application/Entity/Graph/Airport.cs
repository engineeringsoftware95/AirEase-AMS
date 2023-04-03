using AirEase_AMS.Application.Defs.Struct;

namespace AirEase_AMS.Application.Entity.Graph;

public class Airport : INode
{
    public bool Adjacent(INode x, INode y)
    {
        throw new NotImplementedException();
    }

    public INode[] Neighbors(INode x)
    {
        throw new NotImplementedException();
    }

    public void AddVertex(INode x)
    {
        throw new NotImplementedException();
    }

    public void RemoveVertex(INode x)
    {
        throw new NotImplementedException();
    }

    public void AddEdge(INode x, INode y)
    {
        throw new NotImplementedException();
    }

    public void RemoveEdge(INode x, INode y)
    {
        throw new NotImplementedException();
    }

    public int GetVertexVal(INode x)
    {
        throw new NotImplementedException();
    }

    public void SetVertexVal(INode x)
    {
        throw new NotImplementedException();
    }
}