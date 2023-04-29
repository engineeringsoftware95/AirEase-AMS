using NUnit.Framework;
using AirEase_AMS.App.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Entity.Aircraft;
using AirEase_AMS.App.Graph.Flight;
using NUnit.Framework.Internal;


namespace AirEase_AMS.App.Graph.Tests
{


 [TestFixture()]
 public class GraphTests
 {
  private Graph graphTest;
  private Route atob;
  private Route atod;
  private Route atoc;
  private Route ctod;
  private Route btoc;
  private Airport a;
  private Airport b;
  private Airport c;
  private Airport d;


  private DateTime time;

  [SetUp]
  public void SetUp()
  {
   graphTest = new Graph();

   a = new Airport();
   a.SetCity("a");
   b = new Airport();
   b.SetCity("b");
   c = new Airport();
   c.SetCity("c");
   d = new Airport();
   d.SetCity("d");

   graphTest.add_node(a);
   graphTest.add_node(b);
   graphTest.add_node(c);
   graphTest.add_node(d);

   atob = new Route();
   atob.SetOrigin("a");
   atob.SetDestination("b");
   btoc = new Route();
   btoc.SetOrigin("b");
   btoc.SetDestination("c");
   atoc = new Route();
   atoc.SetOrigin("a");
   atoc.SetDestination("c");
   atod = new Route();
   atod.SetOrigin("a");
   atod.SetDestination("d");
   ctod = new Route();
   ctod.SetOrigin("c");
   ctod.SetDestination("d");
   
   
   a.AddDeparture(atob.Destination(), atob);
   a.AddDeparture(atoc.Destination(), atoc);
   a.AddDeparture(atod.Destination(), atod);
   b.AddDeparture(btoc.Destination(), btoc);
   c.AddDeparture(ctod.Destination(), ctod);

   
  }


  [Test()]
  public void GraphTest()
  {
   List<List<IRoute>>? testList = new List<List<IRoute>>();

   testList = graphTest.FindRoutes("a", "d");

   List<IRoute> atob_routes = new List<IRoute>();
   atob_routes.Add(atob);
   atob_routes.Add(btoc);
   atob_routes.Add(ctod);
   List<IRoute> atod_routes = new List<IRoute>();
   atod_routes.Add(atod);
   List<IRoute> atoc_routes = new List<IRoute>();
   atoc_routes.Add(atoc);
   atoc_routes.Add(ctod);

   List<IRoute> btoc_routes = new List<IRoute>();
   btoc_routes.Add(btoc);
   List<IRoute> ctod_routes = new List<IRoute>();
   ctod_routes.Add(ctod);

   List<List<IRoute>> compareList = new List<List<IRoute>>();
   compareList.Add(atod_routes);
   compareList.Add(atoc_routes);
   compareList.Add(atob_routes);



   Assert.IsTrue(testList[0][0].Origin().GetCityName() == "a" && testList[0][0].Destination().GetCityName() == "d"
                                                              &&
                                                              testList[1][0].Origin().GetCityName() == "a" &&
                                                              testList[1][0].Destination().GetCityName() == "c"
                                                              && testList[1][1].Origin().GetCityName() == "c" &&
                                                              testList[1][1].Destination().GetCityName() == "d"
                                                              && testList[1][1].Destination().GetCityName() == "d" &&
                                                              testList[1][1].Destination().GetCityName() == "d"
                                                              && testList[1][1].Destination().GetCityName() == "d" &&
                                                              testList[1][1].Destination().GetCityName() == "d"
                                                              && testList[1][1].Destination().GetCityName() == "d" &&
                                                              testList[1][1].Destination().GetCityName() == "d");
  }



  //       (string origin, string destination, DateTime begin,
  //          DateTime end)

 }
}