import { useEffect, useState } from 'react'
import { CssBaseline, List, ListItem, ListItemText } from '@mui/material';
import axios from 'axios';
import MenuBar from './MenuBar';
import { createTheme, ThemeProvider } from "@mui/material/styles";

function App() {
  const [items, setItems] = useState<Item[]>([]);

  useEffect(() => {
    axios.get<Item[]>('http://localhost:5082/api/items')
    .then(response => setItems(response.data))
  }, [])

  const theme = createTheme({
    palette: {
      background: {
        default: "#242424",
      },
      text:{
        primary: "#ffffff",
        secondary: "#bbbbbb",
      }
    },
  });

  return (
    <>
      <ThemeProvider theme={theme}>
        <CssBaseline/>
        <MenuBar />
        <List style={{}}>
          {items.map((item) => (
            <ListItem key={item.id} sx={{ textAlign: "center" }}>
              <ListItemText>{item.name}: {item.description}</ListItemText>
            </ListItem>
          ))}
        </List>
      </ThemeProvider>
    </>
  )
}

export default App
