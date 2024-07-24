namespace SimpleERP.Models.Error
{
	public class ErrorHandlingModel
	{
        public int ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public List<string>? ErrorMessageList { get; set; }
        public bool IsSuccess { get; set; }
    }
}
