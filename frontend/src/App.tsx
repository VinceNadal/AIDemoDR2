import React, { useState } from "react";
import FormComponent from "./components/FormComponent";
import ListComponent from "./components/ListComponent";

function App() {

  const [contacts] = useState([]);

  return (
    <div className="App">
      <ListComponent contacts={contacts} />
      <FormComponent />
    </div>
  );
}

export default App;

// 2 primary react component

// FormComponent
// ListComponent
