import { useEffect, useState } from 'react'
import './App.css'
import { List, ListItem, ListItemText, Typography } from '@mui/material';
import axios from 'axios';

function App() {
  const [items, setItems] = useState<Item[]>([]);

  useEffect(() => {
    axios.get<Item[]>('http://localhost:5082/api/items')
    .then(response => setItems(response.data))
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
