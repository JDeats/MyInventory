import { useEffect, useState } from 'react'
import './App.css'
import { List, ListItem, ListItemText, Typography } from '@mui/material';

function App() {
  const [items, setItems] = useState<Item[]>([]);

  useEffect(() => {
    fetch('http://localhost:5082/api/items')
    .then(response => response.json())
    .then(data => setItems(data))
  }, [])

  return (
    <>
      <Typography variant="h3">My Inventory</Typography>
      <List style={{}}>
        {items.map((item) => (
          <ListItem key={item.id} sx={{ textAlign: "center" }}>
            <ListItemText>{item.name}: {item.description}</ListItemText>
          </ListItem>
        ))}
      </List>
    </>
  )
}

export default App
