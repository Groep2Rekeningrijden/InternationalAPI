using IO.Swagger.Models;
using System;
using System.Threading.Tasks;

public interface IRoutingService
{

    bool Routing(string cc, RawRoute route);

    public Task Processed(string cc, IRoute dto);

}
