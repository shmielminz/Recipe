using CPUFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizCookbook : bizObject<bizCookbook>
    {
        public bizCookbook()
        {

        }
        private int _cookbookId;
        private int _staffId;
        private string _username = "";
        private string _cookbookName = "";
        private decimal _price;
        private bool _active;
        private int _cookbookskill;
        private string _cookbookskilldesc = "";
        private DateTime _dateCreated;
        private string _imageName = "";

        public int CookbookId
        {
            get => _cookbookId;
            set
            {
                if (value != _cookbookId)
                {
                    _cookbookId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int StaffId
        {
            get => _staffId;
            set
            {
                if (value != _staffId)
                {
                    _staffId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Username
        {
            get => _username;
            private set
            {
                if (value != _username)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookName
        {
            get => _cookbookName;
            set
            {
                if (value != _cookbookName)
                {
                    _cookbookName = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value != _price)
                {
                    _price = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool Active
        {
            get => _active;
            set
            {
                if (value != _active)
                {
                    _active = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CookbookSkill
        {
            get => _cookbookskill;
            set
            {
                if (value != _cookbookskill)
                {
                    _cookbookskill = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookSkillDesc
        {
            get => _cookbookskilldesc;
            private set
            {
                if (value != _cookbookskilldesc)
                {
                    _cookbookskilldesc = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateCreated
        {
            get => _dateCreated;
            set
            {
                if (value != _dateCreated)
                {
                    _dateCreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string ImageName
        {
            get => _imageName.ToLower();
            private set
            {
                if (value != _imageName)
                {
                    _imageName = value.ToLower();
                    InvokePropertyChanged();
                }
            }
        }
    }
}
