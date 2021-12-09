using AutoMapper;
using XDK.Data.Models;
using XDK.Sample.Models;
using XDK.Sample.Models.Inputs;
using XDK.Sample.Models.Responses;
using XDK.Sample.Persistence.Entities;

namespace XDK.Sample.UserInterface;

public class SampleAutoMapperProfile : Profile
{
    public SampleAutoMapperProfile()
    {
        CreateMap(typeof(PagedList<>), typeof(PagedListModel<>));
        CreateMap<Product, ProductModel>();
        CreateMap<ProductModel, Product>();
        CreateMap<Order, OrderResponse>();
        CreateMap<OrderInput, Order>();
        CreateMap<OrderItem, OrderItemResponse>();
        CreateMap<OrderItemInput, OrderItem>();
        CreateMap<UserModel, User>();
        CreateMap<User, UserModel>().ForMember(u => u.Password, opt => opt.Ignore());
        CreateMap<CategoryModel, Category>().ReverseMap();
        CreateMap<BrandModel, Brand>().ReverseMap();
    }
}