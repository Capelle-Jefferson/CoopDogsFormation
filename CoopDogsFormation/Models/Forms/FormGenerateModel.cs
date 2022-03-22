using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Models
{
    public class FormGenerateModel
    {
        public FormGenerateModel() { }
        public FormGenerateModel(string formId, string controller, string action, string method, string title, List<InputGenerateModel> inputs, string submitValue)
        {
            FormId = formId;
            Controller = controller;
            Action = action;
            Method = method;
            Title = title;
            Inputs = inputs;
            SubmitValue = submitValue;
        }
        public string FormId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Method { get; set; }
        public string Title { get; set; }
        public List<InputGenerateModel> Inputs { get; set; }
        public string SubmitValue { get; set; }
    }
}
