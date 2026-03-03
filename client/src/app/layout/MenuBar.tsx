import { Button } from "@mui/material";
import { Menu, MenuButton, MenuDivider, MenuHeader, MenuItem, SubMenu } from "@szhsin/react-menu";
import "@szhsin/react-menu/dist/index.css";
import "@szhsin/react-menu/dist/transitions/slide.css";
import "./styles.css";

export default function MenuBar() {
  return (
    <>
        <Menu
            transition 
            menuButton={
                <Button className="menu-button" variant="contained">File</Button>
        }>
            <SubMenu label="New...">
                <SubMenu label="Electronic Component...">
                    <MenuItem onClick={() => {}}>Capacitor</MenuItem>
                </SubMenu>
            </SubMenu>
            <MenuItem>New File</MenuItem>
            <MenuItem>Save</MenuItem>
            <MenuItem>Close Window</MenuItem>
            <MenuDivider />
            <MenuHeader>Edit</MenuHeader>
            <MenuItem>Cut</MenuItem>
            <MenuItem>Copy</MenuItem>
            <MenuItem>Paste</MenuItem>
            <MenuDivider />
            <MenuItem>Print</MenuItem>
        </Menu>
        <Menu menuButton={<MenuButton>Menu</MenuButton>}>
            <MenuItem>New File</MenuItem>
            <SubMenu label="Edit">
                <MenuItem>Cut</MenuItem>
                <MenuItem>Copy</MenuItem>
                <MenuItem>Paste</MenuItem>
                <SubMenu label="Find">
                    <MenuItem>Find...</MenuItem>
                    <MenuItem>Find Next</MenuItem>
                    <MenuItem>Find Previous</MenuItem>
                </SubMenu>
            </SubMenu>
            <MenuItem>Print...</MenuItem>
        </Menu>
    </>
  )
}
