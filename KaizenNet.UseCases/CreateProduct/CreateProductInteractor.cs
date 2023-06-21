
using KaizenNet.DTOs;
using KaizenNet.Entities.Interfaces;
using KaizenNet.Entities.POCOs;
using KaizenNet.UseCasesPorts;

namespace KaizenNet.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreateProductOutputPort OutputPort;

        public CreateProductInteractor(IProductRepository repository
            , IUnitOfWork unitOfWork, ICreateProductOutputPort outputPort) =>
            (Repository, UnitOfWork, OutputPort) =
            (repository, unitOfWork, outputPort);

        public async Task Handle(CreateProductDTO product)
        {
            Product NewProduct = new Product
            {
                Name = product.ProductName
            };
            Repository.CreateProduct(NewProduct);
            await UnitOfWork.SaveChanges();

            await OutputPort.Handle(new ProductDTO { Id = NewProduct.Id, Name = NewProduct.Name });
        }
    }
}
