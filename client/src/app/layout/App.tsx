import { CssBaseline } from '@mui/material';
import MenuBar from './MenuBar';
import { createTheme, ThemeProvider } from "@mui/material/styles";
import ItemList from '../../features/items/ItemList';

function App() {


  const theme = createTheme({
    palette: {
      mode: "dark",
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
        <ItemList />
      </ThemeProvider>
    </>
  )
}

export default App
