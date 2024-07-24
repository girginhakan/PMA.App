import { useState } from "react";
import { Route, Routes } from "react-router-dom";
import Loading from "./components/Loading";
import Home from "./components/Home";

function App() {
  const [count, setCount] = useState(0);

  return (
    <Routes>
      <Route path="/*" element={<Loading />} />
      <Route path="pma-home" element={<Home />}>
        
      </Route>
    </Routes>
  );
}

export default App;
