using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Model
{
    public class Individual
    {
        public Guid Id { get; set; }
        public InformationDto InformationDto { get; set; }
        public List<JobsDto> JobsDtOs { get; set; }
        public List<EducationsDto> EducationsDtOs { get; set; }
        public List<DocumentsDto> DocumentsDtOs { get; set; }
        public ForeignPassportDto ForeignPassportDto { get; set; }
        public InternationalPassportDto InternationalPassportDto { get; set; }
        public RussianPassportDto RussianPassportDto { get; set; }
        public PersonAddressDto PersonAddressDto { get; set; }
    }

    public partial class DocumentsDto
    {
        public Guid Id { get; set; }
        public string DocumentName { get; set; } = "";
        public string DocumentNumber { get; set; } = "";
    }

    public partial class EducationsDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = "";
        public string Institution { get; set; } = "";
        public DateTime Date { get; set; }
    }

    public partial class ForeignPassportDto
    {
        public Guid Id { get; set; }
        public string DocumentSeries { get; set; } = "";
        public string DocumentCountry { get; set; } = "";
        public DateTime DocumentDate { get; set; }  
    }

    public partial class InformationDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
    }

    public partial class InternationalPassportDto
    {
        public Guid Id { get; set; }
        public string DocumentSeries { get; set; } = "";
        public string DocumentIssuer { get; set; } = "";
        public DateTime DocumentDateOfIssue { get; set; }
        public DateTime DocumentExpirationDate { get; set; }
    }

    public partial class JobsDto
    {
        public Guid Id { get; set; }
        public string Position { get; set; } = "";
        public string Organization { get; set; } = "";
    }

    public partial class PersonAddressDto
    {
        public Guid Id { get; set; }
        public string AddressPermanentRegistration { get; set; } = "";
        public string AddressTemporaryRegistration { get; set; } = "";
    }

    public partial class RussianPassportDto
    {
        public Guid Id { get; set; }
        public string DocumentSeries { get; set; } = "";
        public string DocumentIssuer { get; set; } = "";
        public string DocumentIssuerCode { get; set; } = "";
        public DateTime DocumentDate { get; set; }
    }
}