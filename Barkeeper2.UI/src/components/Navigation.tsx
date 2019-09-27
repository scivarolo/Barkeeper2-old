import React from 'react';
import Navbar from "react-bootstrap/Navbar";
import Nav from "react-bootstrap/Nav";

interface NavigationProps {

}

const Navigation = (props: NavigationProps) => {
  return (
    <Navbar bg="light" expand="md">
      <Navbar.Brand>Barkeeper</Navbar.Brand>
      <Navbar.Toggle aria-controls="main-nav" />
      <Nav>
        <Nav.Link href="/home">Home</Nav.Link>
      </Nav>
    </Navbar>
  )
}

export default Navigation