using System.ComponentModel;

namespace Tala7_3.Enums
{
    public enum Rip_state_Enum
    {
        /// <summary>
        /// ثبت درخواست
        /// </summary>
        [Description("ثبت درخواست")]
        Register,

        /// <summary>
        /// تکمیل مدارک
        /// </summary>
        [Description("تکمیل مدارک")]
        Fill_document,

        /// <summary>
        /// بررسی مدارک
        /// </summary>
        [Description("بررسی مدارک")]
        Check_document,

        /// <summary>
        /// پایان
        /// </summary>
        [Description("پایان")]
        Finish

    }
}
