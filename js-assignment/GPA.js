var swabhavTech = swabhavTech || {};
swabhavTech.GPA = swabhavTech.GPA || {};


swabhavTech.GPA.customer= function(firstName,lastName){
    this.firstName=firstName;
    this.lastName=lastName;
    this.getFullName= function(){
        return this.firstName + " " + this.lastName;
    }
    return this;
}