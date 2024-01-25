import React from 'react';
import MenuHeader from './menuPageHeader';
import '../style/Menu.css'
import { useState } from 'react';
import { useNavigate } from 'react-router-dom';

function MenuPage() {
    const [selectedPizzaType, setSelectedPizzaType] = useState(null);
    const [selectedPizzaSize, setSelectedPizzaSize] = useState(null);
    const [selectedDrinkType, setSelectedDrinkType] = useState(null);
    const [selectedDrinkSize, setSelectedDrinkSize] = useState(null);

  const pizzaTypes = [
    'Margherita',
    'Pepperoni',
    'Vegetarian',
    'Hawaiian',
    'BBQ Chicken',
    // Add more pizza options as needed
  ];

  const pizzaSizes = ['Small', 'Medium', 'Large'];

  const drinkTypes = ['Soda', 'Water', 'Juice'];

  const drinkSizes = ['Small', 'Medium', 'Large'];

  const navigate = useNavigate()

  const handleAddToOrder = () => {

    console.log(
        'Order:',
        {
            pizzaType: selectedPizzaType,
            pizzaSize: selectedPizzaSize,
            drinkType: selectedDrinkType,
            drinkSize: selectedDrinkSize,
        }
    );

    const order = {

          pizzaType: selectedPizzaType,
          pizzaSize: selectedPizzaSize,
          drinkType: selectedDrinkType,
          drinkSize: selectedDrinkSize,
    }

    const urlParams = new URLSearchParams(order)
    const orderUrl = `/order?${urlParams.toString()}`;

    navigate(orderUrl);

  }

  return (
    <div>
      <form>
      <section>
        <h2>Pizza Types</h2>
        <ul>
            {pizzaTypes.map((type) => (
                <li key ={type}>
                    <label>
                        <input
                        type = 'radio'
                        name = "pizzaType"
                        value ={type}
                        checked ={selectedPizzaType === type}
                        onChange={()=> setSelectedPizzaType(type)}
                        />
                        {type}
                    </label>
                </li>
            ))}
        </ul>
      </section>
      <section>
        <h2>Pizza Sizes</h2>
        <ul>
          {pizzaSizes.map((size) => (
            <li key={size}>
                <label>
                    <input
                    type = "radio"
                    name = "pizzaSize"
                    value = {size}
                    checked = {selectedPizzaSize ===size}
                    onChange={() => setSelectedPizzaSize(size)}
                    />
                </label>
                {size}
            </li>
          ))}
        </ul>
      </section>
      <section>
        <h2>Drink Types</h2>
        <ul>
          {drinkTypes.map((type) => (
            <li key={type}>
                <label>
                    <input
                    type = "radio"
                    name = "drinkType"
                    value = {type}
                    checked = {selectedDrinkType === type}
                    onChange={() => setSelectedDrinkType(type)}
                    />
                    {type}
                </label>
            </li>
          ))}
        </ul>
      </section>
      <section>
        <h2>Drink Sizes</h2>
        <ul>
          {drinkSizes.map((size) => (
            <li key={size}>
                <input
                 type = "radio"
                 name = "drinkSize"
                 value = {size}
                 checked = {selectedDrinkSize === size}
                 onChange={() => setSelectedDrinkSize(size)}                
                />
                {size}
            </li>
          ))}
        </ul>
      </section>
      <button type = "button" onClick={handleAddToOrder}>
        Add To Order
        </button>
      </form>
    </div>
  );
}

export default MenuPage;
