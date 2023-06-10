using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IO.Swagger.DTOS;
using IO.Swagger.Models;
using MassTransit;


namespace IO.Swagger.Services;

/// <summary>
/// 
/// </summary>
public class RoutingService : IRoutingService
{
    private readonly IPublishEndpoint _publishEndpoint;
    private static readonly HttpClient client = new HttpClient();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="endpoint"></param>
    public RoutingService(IPublishEndpoint endpoint) 
	{
		_publishEndpoint = endpoint;		
	}
	
	/// <summary>
	/// test
	/// </summary>
	/// <param name="cc"></param>
	/// <param name="route"></param>
	/// <returns></returns>
	public bool Routing(string cc, RawRoute route)
	{
		IRawRoute dto = null;
		switch (cc.ToLower())
		{
			case "nl":
                dto = new NLRawDTO();
                dto.Points = route.Points;
                dto.Vehicle = route.Vehicle;
                _publishEndpoint.Publish<NLRawDTO>(dto);
                break;
			case "lu":
                dto = new LURawDTO();
                dto.Points = route.Points;
                dto.Vehicle = route.Vehicle;
                _publishEndpoint.Publish<LURawDTO>(dto);
                break;
        }
		if (dto == null) { return false; }
        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cc"></param>
    /// <param name="dto"></param>
    /// <returns></returns>
	public async Task Processed(string cc, IRoute dto)
	{
        var baseUrl = "http://baseurl.com";

        using StringContent jsonContent = new(
        JsonSerializer.Serialize(dto),
        Encoding.UTF8,
        "application/json");

        var response = await client.PostAsync(baseUrl + "/" + cc, jsonContent);

        var responseString = await response.Content.ReadAsStringAsync();
    }
}
