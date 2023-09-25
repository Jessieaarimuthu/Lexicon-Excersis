using System;
namespace excersice4
{
    abstract class  UserError
	{
	  protected	abstract string UEMessage();
	}

	class NumericInputError:UserError
	{
        protected override string UEMessage()
		{
			return "You tried to use a numeric input in a text only field. This fired an error!";

        }
    }

	class TextInputError: UserError
	{
        protected override string UEMessage()
        {
            return "You tried to use a text input in a text only field. This fired an error!";

        }
    }

}

