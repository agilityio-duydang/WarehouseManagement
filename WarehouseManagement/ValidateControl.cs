using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public class ValidateControl
    {
        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>

        public static bool ValidateDate(Janus.Windows.CalendarCombo.CalendarCombo control, ErrorProvider err, string fieldName)
        {
            return ValidateDate(control, new DateTime(1900, 1, 1), new DateTime(9998, 12, 31), err, fieldName);
        }
        public static bool ValidateDate(Janus.Windows.CalendarCombo.CalendarCombo control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            return ValidateDate(control, new DateTime(1900, 1, 1), new DateTime(9998, 12, 31), err, fieldName, isOnlyWarning);
        }
        public static bool ValidateDate(Janus.Windows.CalendarCombo.CalendarCombo control, DateTime fromDate, DateTime toDate, ErrorProvider err, string fieldName)
        {
            return ValidateDate(control, fromDate, toDate, err, fieldName, false);
        }
        public static bool ValidateDate(Janus.Windows.CalendarCombo.CalendarCombo control, DateTime fromDate, DateTime toDate, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.BackColor = System.Drawing.SystemColors.Info;
                control.Focus();
                return true;
            }

            bool isValid = true;
            DateTime dSelect = Convert.ToDateTime(control.Value);
            string msgErr = string.Empty;
            err.SetError(control, "");

            if (DateTime.Compare(dSelect, fromDate) < 0)
            {
                msgErr = "Ngày \"" + fieldName + "\" không cho phép nhỏ hơn " + fromDate.ToString("dd-MM-yyyy");
                isValid = false;
            }
            else if (DateTime.Compare(dSelect, toDate) > 0)
            {
                msgErr = "Ngày \"" + fieldName + "\" không được phép lớn hơn " + toDate.ToString("dd-MM-yyyy");
                isValid = false;
            }

            if (!isValid)
            {
                control.BackColor = System.Drawing.SystemColors.Info;
                err.SetError(control, msgErr);
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(Janus.Windows.GridEX.EditControls.EditBox control, ErrorProvider err, string fieldName)
        {
            return ValidateNull(control, err, fieldName, false);
        }
        public static bool ValidateNull(Janus.Windows.GridEX.EditControls.EditBox control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' không được để trống.";

            err.SetError(control, "");

            if (control.Text.Trim().Length == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(Janus.Windows.EditControls.UIComboBox control, ErrorProvider err, string fieldName)
        {
            return ValidateNull(control, err, fieldName, false);
        }
        public static bool ValidateNull(Janus.Windows.EditControls.UIComboBox control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' không được để trống.";

            err.SetError(control, "");

            if (control.Text.Trim().Length == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(System.Windows.Forms.ComboBox control, ErrorProvider err, string fieldName)
        {
            return ValidateNull(control, err, fieldName, false);
        }
        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(System.Windows.Forms.ComboBox control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' không được để trống.";

            err.SetError(control, "");

            if (control.Text.Trim().Length == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(System.Windows.Forms.TextBox control, ErrorProvider err, string fieldName)
        {
            return ValidateNull(control, err, fieldName, false);
        }
        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(System.Windows.Forms.TextBox control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' không được để trống.";

            err.SetError(control, "");

            if (control.Text.Trim().Length == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(Janus.Windows.GridEX.EditControls.NumericEditBox control, ErrorProvider err, string fieldName)
        {
            return ValidateNull(control, err, fieldName, false);
        }
        public static bool ValidateNull(Janus.Windows.GridEX.EditControls.NumericEditBox control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' phải > 0.";

            err.SetError(control, "");

            if (Convert.ToDecimal(control.Value) == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(Janus.Windows.CalendarCombo.CalendarCombo control, ErrorProvider err, string fieldName)
        {
            return ValidateNull(control, err, fieldName, false);
        }
        public static bool ValidateNull(Janus.Windows.CalendarCombo.CalendarCombo control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' không được để trống.";

            err.SetError(control, "");

            if (control.Text.Trim().Length == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }
        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateNull(Janus.Windows.GridEX.EditControls.MaskedEditBox control, ErrorProvider err, string fieldName)
        {
            return ValidateNull(control, err, fieldName, false);
        }
        public static bool ValidateNull(Janus.Windows.GridEX.EditControls.MaskedEditBox control, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' không được để trống.";

            err.SetError(control, "");

            if (control.Text.Trim().Length == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }
        /// <summary>
        /// Kiểm tra thông tin rỗng.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateChoose(Janus.Windows.EditControls.UIComboBox control, System.Windows.Forms.ErrorProvider err, string fieldName)
        {
            return ValidateChoose(control, err, fieldName, false);
        }
        public static bool ValidateChoose(Janus.Windows.EditControls.UIComboBox control, System.Windows.Forms.ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Chưa chọn thông tin '" + fieldName + "'.";

            err.SetError(control, "");

            if (control.SelectedIndex == -1)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra độ dài ký tự cho phép.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateLength(Janus.Windows.EditControls.UIComboBox control, int lengthLimit, ErrorProvider err, string fieldName)
        {
            return ValidateLength(control, lengthLimit, err, fieldName, false);
        }
        public static bool ValidateLength(Janus.Windows.EditControls.UIComboBox control, int lengthLimit, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' vượt quá ký tự cho phép, phải <= '" + lengthLimit + "' ký tự.";

            err.SetError(control, "");

            if (control.SelectedValue != null)
                isValid = ValidateLength(control.SelectedValue.ToString().Trim(), lengthLimit);
            else
                isValid = false;

            if (isValid == false)
            {
                control.BackColor = System.Drawing.SystemColors.Info;
                err.SetError(control, msgErr);
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra độ dài ký tự cho phép.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateLength(Janus.Windows.GridEX.EditControls.EditBox control, int lengthLimit, ErrorProvider err, string fieldName)
        {
            return ValidateLength(control, lengthLimit, err, fieldName, false);
        }
        public static bool ValidateLength(Janus.Windows.GridEX.EditControls.EditBox control, int lengthLimit, ErrorProvider err, string fieldName, bool isOnlyWarning)
        {
            if (isOnlyWarning)
            {
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return true;
            }

            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' vượt quá ký tự cho phép, phải <= '" + lengthLimit + "' ký tự.";

            err.SetError(control, "");

            isValid = ValidateLength(control.Text, lengthLimit);

            if (isValid == false)
            {
                control.BackColor = System.Drawing.SystemColors.Info;
                err.SetError(control, msgErr);
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra độ dài ký tự cho phép.
        /// </summary>
        /// <param name="valueString"></param>
        /// <param name="lengthLimit"></param>
        /// <returns></returns>
        private static bool ValidateLength(string valueString, int lengthLimit)
        {
            return valueString.Length <= lengthLimit;
        }

        public static bool ValidateNumber(TextBox control, ErrorProvider err, string fieldName)
        {

            string str = control.Text.Trim();
            long stk;
            bool isNum = long.TryParse(str, out stk);

            string msgerrNum = "Thông tin '" + fieldName + "' không chính xác,'" + fieldName + "' phải là kiểu Số";
            string msgerrorDuong = "Thông tin '" + fieldName + "' không chính xác,'" + fieldName + "' phải >0";

            err.SetError(control, "");
            if (!isNum)
            {
                err.SetError(control, msgerrNum);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return false;
            }
            else
                if (stk < 0)
                {
                    err.SetError(control, msgerrorDuong);
                    control.Focus();
                    control.BackColor = System.Drawing.SystemColors.Info;
                    return false;
                }
            return true;
        }
        public static bool ValidateNumber(System.Windows.Forms.NumericUpDown control, ErrorProvider err, string fieldName)
        {

            string str = control.Text.Trim();
            long stk;
            bool isNum = long.TryParse(str, out stk);

            string msgerrNum = "Thông tin '" + fieldName + "' không chính xác,'" + fieldName + "' phải là kiểu Số";
            string msgerrorDuong = "Thông tin '" + fieldName + "' không chính xác,'" + fieldName + "' phải >0";

            err.SetError(control, "");
            if (!isNum)
            {
                err.SetError(control, msgerrNum);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
                return false;
            }
            else
                if (stk < 0)
                {
                    err.SetError(control, msgerrorDuong);
                    control.Focus();
                    control.BackColor = System.Drawing.SystemColors.Info;
                    return false;
                }
            return true;
        }

        /// <summary>
        /// Kiểm tra thông tin > 0.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateZero(System.Windows.Forms.NumericUpDown numericUpDownControl, System.Windows.Forms.ErrorProvider err, string fieldName)
        {
            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' phải > 0.";

            err.SetError(numericUpDownControl, "");

            if (numericUpDownControl.Value == 0)
            {
                isValid = false;
                err.SetError(numericUpDownControl, msgErr);
                numericUpDownControl.Focus();
                numericUpDownControl.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin > 0.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateZero(TextBox control, System.Windows.Forms.ErrorProvider err, string fieldName)
        {
            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' phải > 0.";

            decimal result = 0;
            decimal.TryParse(control.Text, out result);

            err.SetError(control, "");

            if (result == 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

        /// <summary>
        /// Kiểm tra thông tin > 0.
        /// </summary>
        /// <param name="txtControl"></param>
        /// <param name="err"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static bool ValidateZero(Janus.Windows.GridEX.EditControls.NumericEditBox control, System.Windows.Forms.ErrorProvider err, string fieldName)
        {
            bool isValid = true;
            string msgErr = "Thông tin '" + fieldName + "' phải > 0.";

            decimal result = 0;
            decimal.TryParse(control.Text, out result);

            err.SetError(control, "");

            if (result <= 0)
            {
                isValid = false;
                err.SetError(control, msgErr);
                control.Focus();
                control.BackColor = System.Drawing.SystemColors.Info;
            }

            return isValid;
        }

    }
}
