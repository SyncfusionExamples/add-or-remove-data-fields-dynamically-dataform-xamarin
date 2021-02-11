using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DataformXamarin
{
    public class DataformBehavior : Behavior<ContentPage>
    {
        bool refreshLayout = false;
        SfDataForm dataForm;
        Button button;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            button = bindable.FindByName<Button>("Commit");
            dataForm.DataObject = new ContactInfo();          
            this.WireEvents();
        }
        private void WireEvents()
        {
            this.dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
            this.button.Clicked += Button_Clicked;
        }
        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (!refreshLayout)
                {
                    if (e.DataFormItem.Name.Equals("MiddleName") || e.DataFormItem.Name.Equals("LastName"))
                        e.Cancel = true;
                }
                else if (e.DataFormItem.Name == "GroupName")
                {
                    e.Cancel = true;
                }
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            refreshLayout = true;
            dataForm.RefreshLayout(true);
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            this.UnWireEvents();
        }
        private void UnWireEvents()
        {
            this.dataForm.AutoGeneratingDataFormItem -= DataForm_AutoGeneratingDataFormItem;
            this.button.Clicked -= Button_Clicked;
        }
    }
}
