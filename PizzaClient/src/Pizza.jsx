import { useState, useEffect } from 'react';
import PizzaList from './PizzaList';

const term = "Pizza";
const API_URL = '/pizzas';
const headers = {
  'Content-Type': 'application/json',
};

function Pizza() {
  const [data, setData] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetchPizzaData();
  }, []);

  const fetchPizzaData = () => {
    fetch(API_URL)
      .then(response => response.json())
      .then(data => setData(data))
      .catch(error => setError(error));
  };

  const handleCreate = (item) => {

    console.log(`add item: ${JSON.stringify(item)}`)

    fetch(API_URL, {
      method: 'POST',
      headers,
      body: JSON.stringify({name: item.name, description: item.description,id:1}),
    })
      .then(response => response.json())
      .then(returnedItem => setData([...data, returnedItem]))
      .catch(error => setError(error));
  };

  const handleUpdate = (updatedItem) => {

    console.log(`update item: ${JSON.stringify(updatedItem)}`)

    fetch(`${API_URL}/${updatedItem.id}`, {
      method: 'PUT',
      headers,
      body: JSON.stringify(updatedItem),
    })
      .then(() => setData(data.map(item => item.id === updatedItem.id ? updatedItem : item)))
      .catch(error => setError(error));
  };

  const handleDelete = (id) => {
    fetch(`${API_URL}/${id}`, {
      method: 'DELETE',
      headers,
    })
      .then(() => setData(data.filter(item => item.id !== id)))
      .catch(error => console.error('Error deleting item:', error));
  };


  return (
    <div>
      <PizzaList
        name={term}
        data={data}
        error={error}
        onCreate={handleCreate}
        onUpdate={handleUpdate}
        onDelete={handleDelete}
      />
    </div>
  );
}

export default Pizza;
// import { useState, useEffect } from 'react';
// import PizzaList from './PizzaList';

// const term = "Pizza";

// function Pizza() {
//   const [data, setData] = useState([]);
//   const [maxId, setMaxId] = useState(0);

//   useEffect(() => {
//     fetchPizzaData();
//   }, []);

// //   fetch("http://localhost:5100/pizzas")
// //   .then(response => response.json())
// //   .then(data => console.log(data)) // outputs mocked data
//   const fetchPizzaData = () => {
//     // Simulate fetching data from API
//     const pizzaData = [
//       { id: 1, name: 'Margherita', description: 'Tomato sauce, mozzarella, and basil' },
//       { id: 2, name: 'Pepperoni', description: 'Tomato sauce, mozzarella, and pepperoni' },
//       { id: 3, name: 'Hawaiian', description: 'Tomato sauce, mozzarella, ham, and pineapple' },
//     ];
//     setData(pizzaData);
//     setMaxId(Math.max(...pizzaData.map(pizza => pizza.id)));
//   };

//   const handleCreate = (item) => {
//     // Simulate creating item on API
//     const newItem = { ...item, id: data.length + 1 };
//     setData([...data, newItem]);
//     setMaxId(maxId + 1);
//   };

//   const handleUpdate = (item) => {
//     // Simulate updating item on API
//     const updatedData = data.map(pizza => pizza.id === item.id ? item : pizza);
//     setData(updatedData);
//   };

//   const handleDelete = (id) => {
//     // Simulate deleting item on API
//     const updatedData = data.filter(pizza => pizza.id !== id);
//     setData(updatedData);
//   };


//   return (
//     <div>
//       <PizzaList
//         name={term}
//         data={data}
//         onCreate={handleCreate}
//         onUpdate={handleUpdate}
//         onDelete={handleDelete}
//       />
//     </div>
//   );
// }

// export default Pizza;