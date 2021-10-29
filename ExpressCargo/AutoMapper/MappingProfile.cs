using AutoMapper;
using EntityLayer.Concrete;
using ExpressCargo.Models;

namespace ExpressCargo.AutoMapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Comment, AdminCommentVM>();
			CreateMap<Comment, CommentVM>();
			CreateMap<CommentVM, Comment>();
			CreateMap<Contact, AdminContactVM>();
			CreateMap<Contact, ContactVM>();
			CreateMap<ContactVM, Contact>();
			CreateMap<District, LoginVM>();
			CreateMap<Order, AdminOrderVM>();
			CreateMap<Order, AdminUpdateOrderVM>();
			CreateMap<CreateOrderVM, Order>();
			CreateMap<Order, TrackOrderVM>();
			CreateMap<ExceptionLog, AdminErrorVM>();
		}
	}
}
