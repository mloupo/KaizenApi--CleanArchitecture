using KaizenNet.DTOs;
using KaizenNet.Presenters;
using KaizenNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace KaizenNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort InputPort;
        readonly ICreateProductOutputPort OutputPort;

        public CreateProductController(
            ICreateProductInputPort inputPort,
            ICreateProductOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<ProductDTO> CreateProduct(CreateProductDTO product)
        {
            await InputPort.Handle(product);
            return ((IPresenter<ProductDTO>)OutputPort).Content;
        }
    }
}
