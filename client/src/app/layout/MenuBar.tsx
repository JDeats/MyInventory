import { Box, Button } from "@mui/material";
import GiteIcon from "@mui/icons-material/Gite";
import { Menu, MenuDivider, MenuItem, SubMenu } from "@szhsin/react-menu";
import "@szhsin/react-menu/dist/index.css";
import "@szhsin/react-menu/dist/transitions/slide.css";
import "./styles.css";

export default function MenuBar() {
  return (
    <Box sx={{ margin: "1rem", display: "flex", gap: "2px" }}>
      <GiteIcon sx={{ fontSize: "48px" }} />
      <Menu
        transition
        menuButton={
          <Button
            className="menu-button"
            variant="contained"
            sx={{ marginLeft: "20px" }}
          >
            File
          </Button>
        }
      >
        <SubMenu label="New...">
          <SubMenu label="Electronic Component...">
            <MenuItem onClick={() => {}}>Capacitor</MenuItem>
          </SubMenu>
        </SubMenu>
        <MenuItem>New File</MenuItem>
        <MenuDivider />
        <MenuItem>New File</MenuItem>
      </Menu>
      <Menu
        transition
        menuButton={
          <Button className="menu-button" variant="contained">
            Category
          </Button>
        }
      >
        <MenuItem onClick={() => {}}>Capacitor</MenuItem>
        <MenuItem onClick={() => {}}>Ferrite Beads</MenuItem>
        <MenuItem onClick={() => {}}>Other</MenuItem>
        <MenuItem onClick={() => {}}>Resistor</MenuItem>
      </Menu>
    </Box>
  );
}
