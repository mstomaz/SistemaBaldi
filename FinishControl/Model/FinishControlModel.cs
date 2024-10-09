using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinishControl.Model
{
    public class FinishControlModel
    {
        [DisplayName("ORDEM DE PRODUÇÃO")]
        public int ProdOrderNumber { get; set; }

        [DisplayName("Nº DO PEDIDO")]
        public int SalesOrderNumber { get; set; }

        [DisplayName("CLIENTE")]
        public string CustomerName { get; set; }

        [DisplayName("GRUPO")]
        public string ItemGroup { get; set; }

        [DisplayName("PRODUTO")]
        public string ItemName { get; set; }

        [DisplayName("QUANTIDADE OP")]
        public int OrderQuantity { get; set; }

        [Required(ErrorMessage = "A quantidade produzida não pode estar vazia.")]
        [DisplayName("QUANTIDADE PRODUZIDA")]
        public int QuantityProduced { get; set; }

        [Required(ErrorMessage = "O responsável não pode estar vazio.")]
        [DisplayName("RESPONSÁVEL")]
        public string EmployeeResponsible { get; set; }

        [Required(ErrorMessage = "A data de produção não pode estar vazia.")]
        [DisplayName("DATA")]
        public DateTime DateAdded { get; set; }

        [DisplayName("REFORMA")]
        public DateTime CorrectionTimestamp { get; set; }
    }
}
