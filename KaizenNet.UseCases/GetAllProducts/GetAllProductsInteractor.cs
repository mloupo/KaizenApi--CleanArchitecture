using KaizenNet.DTOs;
using KaizenNet.Entities.Interfaces;
using KaizenNet.UseCasesPorts;

namespace KaizenNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {

        readonly IProductRepository Repository;
        readonly IGetAllProductsOutputPort OutputPort;

        public GetAllProductsInteractor(
            IProductRepository repository,
            IGetAllProductsOutputPort outputPort) =>
            (Repository, OutputPort) = (repository, outputPort);

        public Task Handle()
        {
            var Products = Repository.GetAll().Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
            });

            OutputPort.Handle(Products);
            return Task.CompletedTask;
        }
    }
}
