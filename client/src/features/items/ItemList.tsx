import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import { useEffect, useState } from "react";
import axios from "axios";

export default function ItemList() {
  const [items, setItems] = useState<Item[]>([]);

  useEffect(() => {
    axios.get<Item[]>("http://localhost:5082/api/items")
      .then((response) => setItems(response.data));
  }, []);

  const columns = Object.keys(items[0] ?? {}) as (keyof Item)[];

  return (
    <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} size="small" aria-label="list of all items">
        <TableHead>
          <TableRow>
            {columns.map((col) => (
                <TableCell key={col}>{col}</TableCell>
            ))}
          </TableRow>
        </TableHead>
        <TableBody>
          {items.map((row) => (
            <TableRow key={row.id}>
                {columns.map((col) => (
                    <TableCell key={col}>{row[col]}</TableCell>
                ))}
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}
