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
            CreateMap<InvestorDTO, Investor>();
            CreateMap<PersonDTO, Person> ();
            CreateMap<BankDetailsDTO, BankDetails>();
            CreateMap<NomineeDTO, Nominee>();
            CreateMap<InvestorCompoundingDTO, Investor_Comp_Investment>();
            CreateMap<InvestorPayoutIntermediateDTO, Investor_Payout_Intermediate>();
            CreateMap<InvestorCompoundingIntermediateDTO, Investor_Comp_Intermediate>();           
        }
    }
}
