using AutoMapper;
using InvestorSystem.Core.Areas.Investors.Model;
using InvestorSystem.DataModel.Table;
using InvestorSystem.DataModel.Table.MetaData;

namespace InvestorSystem.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Investor_Payout_Investment, InvestorPayoutMainDTO>();
            CreateMap<InvestorPayoutMainDTO, Investor_Payout_Investment>();
            CreateMap<InvestorDTO, Person>();
            CreateMap<MaritalStatusDTO, MaritalStatus>();
            CreateMap<GenderDTO, Gender>();
            CreateMap<InvestorDTO, Investor>();
            CreateMap<Person,InvestorDTO>();
            CreateMap<Investor,InvestorDTO>();
            CreateMap<Person, Investor> ();
            CreateMap<BankDetailsDTO, BankDetails>();
            CreateMap<AccountTypeDTO, AccountType>();
            CreateMap<NomineeDTO, Nominee>();
            CreateMap<RelationshipDTO, Relationship>();
            CreateMap<InvestorCompoundingDTO, Investor_Comp_Investment>();
            CreateMap<InvestorPayoutIntermediateDTO, Investor_Payout_Intermediate>();
            CreateMap<InvestorCompoundingIntermediateDTO, Investor_Comp_Intermediate>();
            CreateMap<InvestorDTO, BankDetails>();
            CreateMap<InvestorDTO, Nominee>();
        }
    }
}
