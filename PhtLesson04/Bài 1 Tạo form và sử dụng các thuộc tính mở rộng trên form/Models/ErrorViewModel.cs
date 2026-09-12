namespace Bài_1_Tạo_form_và_sử_dụng_các_thuộc_tính_mở_rộng_trên_form.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
