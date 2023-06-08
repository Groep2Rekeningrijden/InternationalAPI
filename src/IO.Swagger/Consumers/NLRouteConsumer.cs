using IO.Swagger.DTOS;
using IO.Swagger.Models;
using MassTransit;
using System.Threading.Tasks;

namespace IO.Swagger.Consumers
{
    public class NLRouteConsumer : IConsumer<NLRouteDTO>
    {
        private readonly IRoutingService _routingService;
        public NLRouteConsumer(IRoutingService routingService)
        {
            _routingService = routingService;
        }
        //public async Task Consume(ConsumeContext<WriteKweetDTO> context)
        //{
        //    MassTransitResponse status = new MassTransitResponse();

        //    WriteKweetDTO dto = new WriteKweetDTO
        //    {
        //        Id = context.Message.Id,
        //        Message = context.Message.Message,
        //        User = context.Message.User,
        //        Date = context.Message.Date,
        //        IsEdited = context.Message.IsEdited,
        //    };

        //    status.Succes = await _kweetReadService.PostKweet(dto);

        //    await context.RespondAsync(status);
        //}

        public Task Consume(ConsumeContext<NLRouteDTO> context)
        {
            IRoute dto = new NLRouteDTO();

            dto.Segments = context.Message.Segments;
            dto.PriceTotal = context.Message.PriceTotal;
            dto.Id = context.Message.Id;
            string cc = "NL";

            await _routingService.Processed(cc, dto);
        }
    }
}
