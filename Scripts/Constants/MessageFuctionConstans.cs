using BiaManager.Contants;
using System.Windows.Forms;

namespace BiaManager.Script
{
    public static class MessageFuctionConstans
    {
        public static void WarningOK(string content)
        {
            MessageBox.Show(content, MessageNameContants.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult OKCancel(string content)
        {
            return MessageBox.Show(content, "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        public static DialogResult YesNoCancel(string content)
        {
            return MessageBox.Show(content, "Confirm",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
        public static DialogResult YesNo(string content)
        {
            return MessageBox.Show(content, "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void SuccessOK(string content)
        {
            MessageBox.Show(content, MessageNameContants.Notification, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ErrorOK(string content)
        {
            MessageBox.Show(content, MessageNameContants.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
