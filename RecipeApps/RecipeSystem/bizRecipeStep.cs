using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizRecipeStep : bizObject<bizRecipeStep>
    {
        private int _recipestepid; private int _recipeid; private int _sequenceval; private string _instruction = "";

        public List<bizRecipeStep> LoadByRecipeId(int recipeid)
        {
            DataTable dt;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStepGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int RecipeStepId
        {
            get => _recipestepid;
            set
            {
                if (_recipestepid != value)
                {
                    _recipestepid = value;
                    this.InvokePropertyChanged();
                }
            }
        }

        public int RecipeId
        {
            get => _recipeid;
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    this.InvokePropertyChanged();
                }
            }
        }

        public int SequenceVal
        {
            get => _sequenceval;
            set
            {
                if (_sequenceval != value)
                {
                    _sequenceval = value;
                    this.InvokePropertyChanged();
                }
            }
        }

        public string Instruction
        {
            get => _instruction;
            set
            {
                if (_instruction != value)
                {
                    _instruction = value;
                    this.InvokePropertyChanged();
                }
            }
        }
    }
}
