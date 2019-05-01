using System;

namespace MVCTemplate
{
    public class Model
    {
        private String name;
        private int number;
        private String firstName;
        private String lastName;

        public String getName()
        {
        return this.name;
        }

        public void setName(String name)
        {
        this.name = name;
        }

        public int getNumber()
        {
            return this.number;
        }

        public void setNumber(int number)
        {
            this.number = number;
        }

        public String getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return this.lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName=lastName;
        }


        public Model(String name,int number,String firstName,String lastName)
        {
        this.name = name;
        this.number = number;
        this.firstName = firstName;
        this.lastName = lastName;
        }
    }
}
