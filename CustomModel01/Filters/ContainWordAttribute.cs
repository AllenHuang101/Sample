using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModel01.Filters
{
    public class ContainWordAttribute : ValidationAttribute, IClientValidatable
    {
        private string _word { get; set; }

        public ContainWordAttribute(string word)
        {
            this._word = word;
        }

        public override bool IsValid(object value)
        {
            if (value is string)
            {
                if (value.ToString().Contains(this._word))
                {
                    return true;
                }
            }
            return false;
        }

        #region 前端驗證

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule
            {
                ValidationType = "containword",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName())
            };

            //此參數一定要是小寫！
            rule.ValidationParameters["word"] = this._word;
            yield return rule;
        }

        #endregion 前端驗證
    }
}