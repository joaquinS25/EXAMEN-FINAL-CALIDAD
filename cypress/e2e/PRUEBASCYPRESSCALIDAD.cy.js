describe('Examen Final Calidad', () => {
  it('Precionando Boton Cartas', () => {
    cy.visit(Cypress.env('URL'))
    cy.get('#GenerarCarta').click()
    cy.location('pathname').should('eq','/home/generar')
  })
  it('Ingresar a Privacy', () => {
    cy.visit(Cypress.env('URL'))
    cy.get('#privacy').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
  it('Ingresar Privacy por footer', () => {
    cy.visit(Cypress.env('URL'))
    cy.get('#PrivacyFooter').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
})