using KaizenNet.DTOs;
using KaizenNet.Presenters;
using KaizenNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace KaizenNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort InputPort;
        readonly IGetAllProductsOutputPort OutputPort;

        public GetAllProductsController(
            IGetAllProductsInputPort inputPort,
            IGetAllProductsOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            await InputPort.Handle();
            return (
                (IPresenter<IEnumerable<ProductDTO>>)OutputPort).Content;

        }
    }
}
