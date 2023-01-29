/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package desenvolvimento;

import java.util.ArrayList;
import java.util.List;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;

/**
 *
 * @author Fsociety
 */
@ManagedBean
@SessionScoped
public class ClientesBean {
    private Clientes objCliente = new Clientes();
    private List<Clientes> listaClientes = new ArrayList<>();
    private ClientesDAO objClientesDAO = new ClientesDAO();
    
     public void listar(){
        listaClientes = objClientesDAO.listar();
    }
     
    public void adicionar(){
      objClientesDAO.salvar(objCliente);
      objCliente = new Clientes();
      listar();
    }
    
public void editar(){
        objClientesDAO.editar(objCliente);
        objCliente = new Clientes();
        listar();
    }

public void excluir(){
        objClientesDAO.excluir(objCliente.getId());
        objCliente = new Clientes();
        listar();
    }

public void Limpar(){
        objCliente = new Clientes();
    }

 public void selecionar(Clientes c){
        objCliente = c;
    }

    public Clientes getObjCliente() {
        return objCliente;
    }

    public void setObjCliente(Clientes objCliente) {
        this.objCliente = objCliente;
    }

    public List<Clientes> getListaClientes() {
        return listaClientes;
    }

    public void setListaClientes(List<Clientes> listaClientes) {
        this.listaClientes = listaClientes;
    }

    public ClientesDAO getObjClientesDAO() {
        return objClientesDAO;
    }

    public void setObjClientesDAO(ClientesDAO objClientesDAO) {
        this.objClientesDAO = objClientesDAO;
    }
    
    
 
}
