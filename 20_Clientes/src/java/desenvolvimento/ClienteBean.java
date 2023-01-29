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
public class ClienteBean {
    private Cliente objCliente = new Cliente();
    private List<Cliente> listaCliente = new ArrayList<>();
    private ClienteDAO objClienteDAO = new ClienteDAO();
    
    public void listar(){
        listaCliente = objClienteDAO.listar();
    }
    
    public void adicionar(){
      objClienteDAO.salvar(objCliente);
      objCliente = new Cliente();
      listar();
    }
    
    public void editar(){
        objClienteDAO.editar(objCliente);
        objCliente = new Cliente();
        listar();
    }
    
    public void excluir(){
        objClienteDAO.excluir(objCliente.getId());
        objCliente = new Cliente();
        listar();
    }
    
    public void limpar(){
        objCliente = new Cliente();
    }
    
    public void selecionar(Cliente c){
        objCliente = c;
    }

    public Cliente getObjCliente() {
        return objCliente;
    }

    public void setObjCliente(Cliente objCliente) {
        this.objCliente = objCliente;
    }

    public List<Cliente> getListaCliente() {
        return listaCliente;
    }

    public void setListaCliente(List<Cliente> listaCliente) {
        this.listaCliente = listaCliente;
    }

    public ClienteDAO getObjClienteDAO() {
        return objClienteDAO;
    }

    public void setObjClienteDAO(ClienteDAO objClienteDAO) {
        this.objClienteDAO = objClienteDAO;
    }
    
    
}
