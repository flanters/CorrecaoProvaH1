namespace CorrecaoProvaH1.Validations
{
    using System.ComponentModel.DataAnnotations;

    public class UFValidationAttribute : ValidationAttribute
    {
        private readonly string[] _ufsValidas = { "MG", "SP", "RJ", "ES" };

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || !_ufsValidas.Contains(value.ToString()))
            {
                return new ValidationResult("UF inválida. Valores permitidos: MG, SP, RJ, ES.");
            }
            return ValidationResult.Success;
        }
    }

}
