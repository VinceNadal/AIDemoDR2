import { Contact } from "../interface/Contact";

interface Props {
  contacts: Contact[];
}

export default function ListComponent({ contacts }: Props) {
  // Create a contact list component that will display all contact using UL and LI tags
  return (
    <ul>
      {contacts.map((contact) => (
        <li key={contact.id}>
          {contact.firstName} {contact.lastName}
        </li>
      ))}
    </ul>
  );
}
