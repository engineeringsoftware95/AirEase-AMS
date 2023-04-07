namespace AirEase_AMS.App.Defs.Struct;

public interface IGraphNode
{
   string GetCityName();
   List<IRoute>? GetRoutes();
}