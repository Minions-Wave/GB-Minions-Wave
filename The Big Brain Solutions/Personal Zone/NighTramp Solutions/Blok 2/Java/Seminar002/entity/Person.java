package entity;
/**
 * Person
 */
public class Person {
    
    private String firstName;
    private String lastName;
    
    public Person() { }

    public String getFirstName() { return this.firstName; }
    public void setFirstName(String fName) { this.firstName = fName; }
    public String getLastName() { return this.lastName; }
    public void setLastName(String lName) { this.lastName = lName; }

    public String get(String value) {
        switch (value) {
            case "firstName":
                return getFirstName();
            case "lastName":
            return getLastName();
            default:
                return "";
        }
    }

    @Override
    public String toString() {
        return "Person{" +
               "firstName='" + this.firstName + '\'' +
               ", lastName='" + this.lastName + '\'' +
               '}';
    }
}
