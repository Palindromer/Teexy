using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.Models;
using Teexy.ViewModels;

namespace Teexy.Mapping
{
	public class MappingProfile : Profile
	{
		private string ToFileUrl(int fileId) => $"/api/files/{fileId}";

		public MappingProfile()
		{
			CreateMap<User, IndexUserViewModel>();

			CreateMap<UserChallenge, UserChallengeViewModel>()
				.ForMember(m => m.User, opt => opt.MapFrom(src => Mapper.Map<IndexUserViewModel>(src.User)))
				.ForMember(m => m.FileUrl, opt => opt.MapFrom(src => ToFileUrl(src.ProofFileId)));
		}
	}
}
