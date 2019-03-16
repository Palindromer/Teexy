using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.Builders;
using Teexy.Models;
using Teexy.ViewModels;

namespace Teexy.Mapping
{
	public class MappingProfile : Profile
	{
		private UrlBuilder _urlBuilder = new UrlBuilder();

		public MappingProfile()
		{
			CreateMap<User, IndexUserViewModel>()
				.ForMember(m => m.AvatarUrl, opt => opt.MapFrom(src => ToFileUrl(src.AvatarFileId.Value)));

			CreateMap<UserChallenge, UserChallengeViewModel>()
				.ForMember(m => m.User, opt => opt.MapFrom(src => Mapper.Map<IndexUserViewModel>(src.User)))
				.ForMember(m => m.FileUrl, opt => opt.MapFrom(src => ToFileUrl(src.ProofFileId)));
		}

		private string ToFileUrl(int? fileId) => fileId.HasValue ? _urlBuilder.CreateFileUrl(fileId.Value) : null;
	}
}
